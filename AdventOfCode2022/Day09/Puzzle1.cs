﻿namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public class Puzzle1 : Puzzle, ISolvable
    {
        public object Solve(string input)
        {
            return CountPositions(input, 2);
        }
    }
}
