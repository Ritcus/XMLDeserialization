using DematicCodingQuestion.Interface;


namespace DematicCodingQuestion.Controller
{
    public class CalculationController 
    {
        private readonly IRepository _repository;

        public CalculationController(IRepository repository)
        {
            _repository = repository;
        }
        public double Plus(List<double> Values)
        {
            return _repository.Addition();
        }

        public double Substraction(List<double> Values)
        {
            return _repository.Subtraction();
        }

        public double Multiplications(List<double> Values)
        {
            return _repository.Multiplication();

        }

        public double Division(List<double> Values)
        {
            return _repository.Division();

        }
    }
}
