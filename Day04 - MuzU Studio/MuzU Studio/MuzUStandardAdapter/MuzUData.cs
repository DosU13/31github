using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace MuzUWrapper;

public interface MuzUData
{
    public Identity Identity { get; set; }
    public Music Music { get; set; }
    public MusicLocal MusicLocal { get; set; }
    public Tempo Tempo { get; set; }
    public List<Sequence> SequenceList { get; set; }
}

public interface Identity
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public string Description { get; set; }
}

public interface Music
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string Version { get; set; }
}

public interface MusicLocal
{
    public string MusicPath { get; set; }
    /// <summary>
    /// if positive audio has excess part
    /// </summary>
    public long MusicOffsetMicroseconds { get; set; }
}