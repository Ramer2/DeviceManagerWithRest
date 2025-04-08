using Devices.devices;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerWithRest.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
    private static readonly List<Device> _devices = new();

    [HttpGet]
    [Route("/devices")]
    public IResult GetAllDevices()
    {
        var summaries = _devices.Select(d => new { d._id, d._name });
        return Results.Ok(summaries);
    }

    [HttpGet]
    [Route("/devices/{id}")]
    public IResult GetDeviceById(string id)
    {
        var device = _devices.FirstOrDefault(d => d._id == id);
        return Results.Ok(device);
    }
}