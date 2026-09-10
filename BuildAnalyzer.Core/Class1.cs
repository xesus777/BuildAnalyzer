namespace BuildAnalyzer.Core
{


    public class Unit
    {
        public string name {get; set;}
        public double baseAttack {get; set;}
        public double weaponAttack {get; set;}
        public int critDamageChanse {get; set;}
        public int critDamageProc {get; set;}

        public double finalAttack() {
            return baseAttack + weaponAttack;
        }

        public double avgDamage()
        {
            return finalAttack() * (1 + (critDamageChanse/100) * critDamage()/100);
        }

        public double critDamage()
        {
            return (baseAttack + weaponAttack) * (1 + (critDamageProc / 100));
        }

        public string getRate()
        {
            if (avgDamage() < 1500)
            {
                return "слабая";
            }
            else if (avgDamage() > 1500 && avgDamage() < 2499)
            {
                return "нормальная";
            }
            else if (avgDamage() > 2500 && avgDamage() < 3499)
            {
                return "хорошая";
            }
            else {
                return "отличная";
            }

        }

    }
}


