using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MuzUWrapper;

public interface Sequence
{
    public string Name { get; set; }
    public SequenceTemplate SequenceTemplate { get; set; } 
    public SoundClassification SoundClassification { get; set; } 
    public List<Node> NodeList { get; set; }
}
