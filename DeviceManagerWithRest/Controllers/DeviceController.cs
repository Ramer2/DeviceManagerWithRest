using DeviceManager.devices;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerWithRest.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
    private static readonly List<Device> _devices = new();
}