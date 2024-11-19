namespace TeamSim.Sports.Soccer.Models
{
    public class Player
    {
        // Informazioni di base
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string Position { get; set; } // Es: "Forward", "Midfielder", "Defender", "Goalkeeper"
        public string Club { get; set; }
        public double Value { get; set; } // Valore di mercato in milioni

        // Statistiche abilità (valori da 1 a 20)
        public int Passing { get; set; }
        public int Shooting { get; set; }
        public int Dribbling { get; set; }
        public int Tackling { get; set; }
        public int Heading { get; set; }
        public int Creativity { get; set; }
        public int Determination { get; set; }
        public int Leadership { get; set; }
        public int Vision { get; set; }
        public int Pace { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Goalkeeping { get; set; } // Specifico per i portieri

        // Statistiche avanzate
        public int CurrentAbility { get; set; }  // Abilità attuale (CA)
        public int PotentialAbility { get; set; } // Abilità potenziale (PA)
        public int Consistency { get; set; }     // Costanza
        public int InjuryProneness { get; set; } // Propensione agli infortuni
        public int WorkRate { get; set; }        // Livello di impegno
        public int Flair { get; set; }           // Abilità creativa/imprevedibile

        // Nuove proprietà
        public int Reputazione { get; set; }       // Reputazione del giocatore (1-20)
        public int Aggression { get; set; }       // Livello di aggressività (1-20)
        public int Versatility { get; set; }      // Capacità di adattarsi a più posizioni (1-20)
        public bool IsInjured { get; set; }       // Indica se è infortunato
        public int DaysInjured { get; set; }      // Giorni di stop per infortunio
        public bool IsSuspended { get; set; }     // Indica se è squalificato
        public int DaysSuspended { get; set; }    // Giorni di squalifica
        public string PreferredFoot { get; set; } // "Right", "Left", "Both"

        // Contratto e trasferimenti
        public double WeeklyWage { get; set; } // Salario settimanale
        public DateTime ContractEndDate { get; set; }
        public bool IsTransferListed { get; set; } // Indica se il giocatore è sul mercato
        public List<string> InterestedClubs { get; set; } = new List<string>();

        // Statistiche stagionali
        public int MatchesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int CleanSheets { get; set; } // Specifico per portieri e difensori
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int ManOfTheMatchAwards { get; set; }
        public double AverageRating { get; set; } // Media voti partita (es: 6.5)
        public int CareerGoals { get; set; }
        public int CareerAssists { get; set; }
        public int CareerTrophies { get; set; }
        public int RecordGoalsInSeason { get; set; }

        // Morale e dinamiche personali
        public int CurrentMorale { get; set; }
        public string LastScandal { get; set; }
        public string LastAward { get; set; }

        // Metodi per gestire dinamiche complesse

        /// <summary>
        /// Simula l'allenamento del giocatore per una specifica abilità.
        /// </summary>
        public void Train(string skill)
        {
            switch (skill)
            {
                case "Passing": if (Passing < 20) Passing++; break;
                case "Shooting": if (Shooting < 20) Shooting++; break;
                case "Dribbling": if (Dribbling < 20) Dribbling++; break;
                case "Tackling": if (Tackling < 20) Tackling++; break;
                case "Heading": if (Heading < 20) Heading++; break;
            }
            Stamina = Math.Max(0, Stamina - 1); // L'allenamento riduce la forma fisica
        }

        /// <summary>
        /// Aggiorna le statistiche dopo una partita.
        /// </summary>
        public void PlayMatch(int goals, int assists, double matchRating)
        {
            MatchesPlayed++;
            Goals += goals;
            Assists += assists;
            AverageRating = ((AverageRating * (MatchesPlayed - 1)) + matchRating) / MatchesPlayed;

            // Incrementa la reputazione per grandi performance
            if (matchRating > 8) Reputazione = Math.Min(20, Reputazione + 1);

            // Riduce la stamina e aumenta la possibilità di infortuni
            Stamina = Math.Max(0, Stamina - 5);
            CheckForInjury();
        }

        /// <summary>
        /// Controlla se il giocatore si infortuna dopo una partita.
        /// </summary>
        private void CheckForInjury()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 100) <= InjuryProneness) // Percentuale basata su InjuryProneness
            {
                IsInjured = true;
                DaysInjured = rnd.Next(3, 30); // Durata infortunio casuale
            }
        }

        /// <summary>
        /// Trasferisce il giocatore a un nuovo club.
        /// </summary>
        public void TransferTo(string newClub, double transferFee)
        {
            Club = newClub;
            Value = transferFee;

            // Aumenta la reputazione se il club è prestigioso
            if (transferFee > 50) // Es: trasferimento oltre 50M
            {
                Reputazione = Math.Min(20, Reputazione + 2);
            }
        }

        /// <summary>
        /// Ripristina le condizioni fisiche e verifica se il giocatore è guarito.
        /// </summary>
        public void Recover()
        {
            if (IsInjured)
            {
                DaysInjured--;
                if (DaysInjured <= 0) IsInjured = false;
            }

            if (IsSuspended)
            {
                DaysSuspended--;
                if (DaysSuspended <= 0) IsSuspended = false;
            }

            Stamina = Math.Min(20, Stamina + 1); // Recupero giornaliero
        }
    }

}
