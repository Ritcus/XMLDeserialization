using DematicCodingQuestion.Interface;

namespace DematicCodingQuestion.Services
{
    internal interface RepositoryServices : IRepository
    {
        public double Addition(List<double> Values)
        {
            return Values.Sum();
        }

        public double Substraction (List<double> Values)
        {
            double subtraction = Values[0];

            for(int i = 0; i < Values.Count; i++)
            {
                subtraction -= Values[i+1];
            }

            return subtraction;
        }

        public double Multiplications (List<double> Values)
        {
            double multiplication = 1;

            for (int i = 0; i < Values.Count; i++)
            {
                multiplication *=Values[i];
            }

            return multiplication;

        }

        public double Division(List<double> Values)
        {
            double division = Values[0];

            for (int i = 0; i < Values.Count; i++)
            {
                division /= Values[1];
            }

            return division;

        }

    }
}
