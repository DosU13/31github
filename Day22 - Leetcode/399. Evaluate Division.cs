public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        Dictionary<string, Factor> dict = new Dictionary<string, Factor>();
        for (int i = 0; i < equations.Count; i++)
        {
            var equation = equations[i];
            if (!dict.ContainsKey(equation[0]) && !dict.ContainsKey(equation[1]))
            {
                dict[equation[0]] = new Factor(equation[1], values[i]);
                dict[equation[1]] = new Factor(equation[1], 1);
            }
            else if (dict.ContainsKey(equation[0]) && !dict.ContainsKey(equation[1]))
            {
                var factor = dict[equation[0]];
                dict[equation[1]] = new Factor(factor.str, factor.fac / values[i]);
            }
            else if (!dict.ContainsKey(equation[0]) && dict.ContainsKey(equation[1]))
            {
                var factor = dict[equation[1]];
                dict[equation[0]] = new Factor(factor.str, factor.fac * values[i]);
            }
            else
            {
                var fac0 = dict[equation[0]];
                string fac0str = fac0.str;
                var fac1 = dict[equation[1]];
                double d = fac1.fac * values[i] / fac0.fac;
                foreach (var f in dict.Values)
                {
                    if (f.str == fac0str)
                    {
                        f.str = fac1.str;
                        f.fac *= d;
                    }
                }
            }

            foreach (var kv in dict)
            {
                Console.Write($"{kv.Key} {kv.Value.str} {kv.Value.fac}; ");
            }
            Console.WriteLine();
        }

        double[] res = new double[queries.Count];
        for (int i = 0; i < queries.Count; i++)
        {
            var q = queries[i];
            if (dict.TryGetValue(q[0], out var fac0) == false ||
                dict.TryGetValue(q[1], out var fac1) == false ||
                fac0.str != fac1.str) res[i] = -1;
            else res[i] = fac0.fac / fac1.fac;
        }
        return res;
    }

    private class Factor
    {
        public string str { get; set; }
        public double fac { get; set; }

        public Factor(string str, double fac)
        {
            this.str = str;
            this.fac = fac;
        }
    }
}
