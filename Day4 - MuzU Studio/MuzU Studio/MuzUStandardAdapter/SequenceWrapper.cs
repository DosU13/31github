using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MuzUWrapper;

public class SequenceWrapper: Sequence
{
    private MuzUStandard.data.Sequence data;
    public SequenceWrapper(MuzUStandard.data.Sequence sequence) {
        data = sequence;
    }

    public string Name { 
        get => data.Name;
        set => data.Name = value;
    }
    public SequenceTemplate SequenceTemplate { get; set; } = new SequenceTemplate();
    public SoundClassification SoundClassification { get; set; } = new SoundClassification();
    public List<Node> NodeList { get; set; } = new List<Node>();
}
