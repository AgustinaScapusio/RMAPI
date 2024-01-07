using Microsoft.AspNetCore.Mvc.Rendering;
using RMAPI.NasaAPI;

namespace RMAPI.Models
{
    public class IndexViewModel
    {
        public int Sol { get; set; }

        public string Camera { get; set; }

        public RoverResponse RoverResponse { get; set; }

        public List<SelectListItem> Cameras { get; set; } = new List<SelectListItem>
        {
            new() { Text = "Front Hazard Avoidance Camera", Value = "FHAZ" },
            new() { Text = "Rear Hazard Avoidance Camera", Value = "RHAZ" },
            new() { Text = "Mast Camera", Value = "MAST" },
            new() { Text = "Chemistry and Camera Complex", Value = "CHEMCAM" },
            new() { Text = "Mars Hand Lens Imager", Value = "MAHLI" },
            new() { Text = "Mars Descent Imager", Value = "MARDI" },
            new() { Text = "Navigation Camera", Value = "NAVCAM" },
            new() { Text = "Panoramic Camera", Value = "PANCAM" },
            new() { Text = "Miniature Thermal Emission Spectrometer (Mini-TES)", Value = "MINITES" }
        };

    }
}
