using MuzUAdapter;
using MuzUStandard.data;
using System.IO;

namespace MuzUWrapper;

public class MuzUProject
{
    private MuzUStandard.MuzUProject muzUStandardProject;
    private MuzUStandard.MuzUProject MuzUStandardProject
    {
        get => muzUStandardProject;
        set
        {
            muzUStandardProject = value;
            MuzUData = new MuzUDataWrapper(value.MuzUData);
        }
    }
    public MuzUData MuzUData { get; set; }
    public MuzUProject() => MuzUStandardProject = new MuzUStandard.MuzUProject();

    public MuzUProject(MuzUData data) => MuzUStandardProject = new MuzUStandard.MuzUProject(data);

    public MuzUProject(Stream stream) => MuzUStandardProject = new MuzUStandard.MuzUProject(stream);

    public MuzUProject(string text) => MuzUStandardProject = new MuzUStandard.MuzUProject(text);

    public void Save(Stream stream)
    {
        MuzUStandardProject.Save(stream);
    }
}
