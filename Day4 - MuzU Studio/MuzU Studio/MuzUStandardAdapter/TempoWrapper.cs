namespace MuzUWrapper
{
    internal class TempoWrapper : Tempo
    {
        private MuzUStandard.data.Tempo tempo;

        public TempoWrapper(MuzUStandard.data.Tempo tempo)
        {
            this.tempo = tempo;
        }
    }
}