public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        int radCnt = senate.Count(x => x == 'R'), dirCnt = senate.Count(x => x == 'D'), radAtt = 0, dirAtt = 0;
        Queue<bool> queue = new Queue<bool>(senate.Select(x => x == 'R'));
        while (radCnt!=0 && dirCnt!=0)
        {
            if(queue.Peek())
            {
                if(dirAtt > 0)
                {
                    dirAtt--;
                    queue.Dequeue();
                    radCnt--;
                }
                else
                {
                    radAtt++;
                    queue.Enqueue(queue.Dequeue());
                }
            }
            else
            {
                if (radAtt > 0)
                {
                    radAtt--;
                    queue.Dequeue();
                    dirCnt--;
                }
                else
                {
                    dirAtt++;
                    queue.Enqueue(queue.Dequeue());
                }
            }
        }
        return queue.Peek() ? "Radiant" : "Dire";
    }
}