public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();
        foreach(int asteroid in asteroids)
        {
            PutIntoStack(stack, asteroid);
        }
        return stack.Reverse().ToArray();
    }

    private void PutIntoStack(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || value > 0 || stack.Peek() < 0) stack.Push(value);
        else if (stack.Peek() < -value)
        {
            stack.Pop();
            PutIntoStack(stack, value);
        }
        else if (stack.Peek() == -value)
        {
            stack.Pop();
        }
    }
}