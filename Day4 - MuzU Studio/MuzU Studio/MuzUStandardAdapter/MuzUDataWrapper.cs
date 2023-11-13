using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MuzUWrapper;

public class MuzUDataWrapper: MuzUData
{
    private MuzUStandard.data.MuzUData muzUStandardData;
    public MuzUDataWrapper(MuzUStandard.data.MuzUData MuzUStandardData)
    {
        Identity = new IdentityWrapper(MuzUStandardData.Identity);
        Music = new MusicWrapper(MuzUStandardData.Music);
        MusicLocal = new MusicLocalWrapper(MuzUStandardData.MusicLocal);
        Tempo = new TempoWrapper(MuzUStandardData.Tempo);
        SequenceList = MuzUStandardData.SequenceList
            .Select(x => new SequenceWrapper(x) as Sequence).ToList();
    }

    public Identity Identity { get; set; }
    public Music Music { get; set; }
    public MusicLocal MusicLocal { get; set; }
    public Tempo Tempo { get; set; }
    public List<Sequence> SequenceList { get; set; }    
}

public class IdentityWrapper: Identity
{
    private MuzUStandard.data.Identity data;

    public IdentityWrapper(MuzUStandard.data.Identity identity)
    {
        data = identity;
    }

    public string Name { 
        get => data.Name; 
        set => data.Name = value; 
    }
    public string Creator { 
        get => data.Creator; 
        set => data.Creator = value; 
    }
    public string Description { get; set; }
}

public class MusicWrapper: Music
{
    private MuzUStandard.data.Music data;

    public MusicWrapper(MuzUStandard.data.Music music)
    {
        data = music;
    }

    public string Name { 
        get => data.Name; 
        set => data.Name = value; 
    }
    public string Author { 
        get => data.Author; 
        set => data.Author = value; 
    }
    public string Version { 
        get => data.Version; 
        set => data.Version = value; 
    }
}

public class MusicLocalWrapper: MusicLocal
{
    private MuzUStandard.data.MusicLocal data;

    public MusicLocalWrapper(MuzUStandard.data.MusicLocal musicLocal)
    {
        data = musicLocal;
    }

    public string MusicPath { 
        get => data.MusicPath; 
        set => data.MusicPath = value; 
    } 
    /// <summary>
    /// if positive audio has excess part
    /// </summary>
    public long MusicOffsetMicroseconds { 
        get => data.MusicOffsetMicroseconds; 
        set => data.MusicOffsetMicroseconds = value; 
    } 
}
