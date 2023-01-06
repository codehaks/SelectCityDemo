using Codehaks.IranData;
using Microsoft.AspNetCore.Mvc;

namespace SelectCityDemo.Controllers;

public class IranController : ControllerBase
{
    private readonly IranDbContext _db;
    public IranController(IranDbContext db)
    {
        _db = db;
    }

    [Route("iran/api/city")]
    public IActionResult GetCities(int provinceId)
    {
        return Ok(_db.Cities.Where(c => c.ProvinceID == provinceId));
    }

    [Route("iran/api/province")]
    public IActionResult GetProvinces()
    {

        return Ok(_db.Provinces);
    }
}