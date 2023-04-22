using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Data
{
    public class CarContextDAO : ICarContextDAO
    {
        private TeamInfoContext _context;
        public CarContextDAO(TeamInfoContext context)
        {
            _context = context;
        }

        public int? AddCar(Car currentCar)
        {
            var cars = _context.Cars.Where(x => x.MakeModel!.Equals(currentCar.MakeModel)).FirstOrDefault();
            if (cars != null)
            {
                return null;
            }
            try
            {
                _context.Cars.Add(currentCar);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public List<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }
        public List<Car> GetFirstFive()
        {
            return _context.Cars.Take(5).ToList();
        }

        public Car GetCar(int id)
        {
            return _context.Cars.Where(x => x.Id.Equals(id)).FirstOrDefault()!;
        }

        public int? RemoveCar(int id)
        {
            var currentCar = this.GetCar(id);
            if (currentCar == null) return null;
            try
            {
                _context.Cars.Remove(currentCar);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int? UpdateCar(Car currentCar)
        {
            var carToUpdate = this.GetCar(currentCar.Id);
            if (carToUpdate == null) return null;

            carToUpdate.MakeModel = currentCar.MakeModel;
            carToUpdate.ManufacturerYear = currentCar.ManufacturerYear;
            carToUpdate.Color = currentCar.Color;
            carToUpdate.Id = currentCar.Id;
            carToUpdate.TrimLevel = currentCar.TrimLevel;
            carToUpdate.Type = currentCar.Type;
            try
            {
                _context.Cars.Update(carToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
