﻿using System;

namespace DevAdventCalendarCompetition.Vms
{
    public class SingleTestResultEntry
    {
        public string FullName { get; set; }

        public int CorrectAnswersCount { get; set; }

        public int WrongAnswersCount { get; set; }

        public int Points { get; set; }

        public string UserId { get; set; }
    }
}