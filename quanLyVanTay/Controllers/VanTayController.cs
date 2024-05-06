using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace quanLyVanTay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VanTayController : Controller
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [HttpGet("dangky")]
        public IActionResult Dangky()
        {
            try
            {
                Console.WriteLine("Đăng ký thành công!");
                return Ok("Đăng ký thành công!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi: {ex.Message}");
            }
        }
    }
}
