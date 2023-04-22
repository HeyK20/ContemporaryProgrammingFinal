using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Interfaces
{
    public interface ICarContextDAO
    {
        List<Car> GetAllCars();
        Car GetCar(int id);
        List<Car> GetFirstFive();
        int? RemoveCar(int id);
        int? UpdateCar(Car currentCar);
        int? AddCar(Car currentCar);
    }
}

