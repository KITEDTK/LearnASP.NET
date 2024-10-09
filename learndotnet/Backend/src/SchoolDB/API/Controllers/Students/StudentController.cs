using System;
using learndotnet.Backend.src.SchoolDB.Application.Commands;
using learndotnet.Backend.src.SchoolDB.Application.Commands.Students;
using learndotnet.Backend.src.SchoolDB.Application.DTOS.Students;
using learndotnet.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace learndotnet.Backend.src.SchoolDB.API.Controllers;
[ApiController]
[Route("api/students")]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;
    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
    {
        var command = new GetStudentCommand();
        var result = await _mediator.Send(command);
        if (result == null)
        {
            return NotFound("No students found.");
        }
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDTO request)
    {
        if (request == null || string.IsNullOrEmpty(request.Name) || request.Age <= 0)
        {
            return BadRequest("Invalid student data.");
        }

        await _mediator.Send(request); // Gửi command tới MediatR để xử lý

        return CreatedAtAction(nameof(GetAllStudents), null); // Trả về 201 Created nếu thành công
    }
}
