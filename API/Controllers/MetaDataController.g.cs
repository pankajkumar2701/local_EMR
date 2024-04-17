using Microsoft.AspNetCore.Mvc;
using local_EMR.Models;
using Microsoft.AspNetCore.Authorization;
using YamlDotNet.Serialization;

namespace local_EMR.Controllers
{
    /**The MetaDataController class provides API endpoints for retrieving metadata.
                                                                    * It includes authorization and two actions:
                                                                    * - GetMenu: Retrieves menu data from a YAML file and returns it as JSON.
                                                                    * - GetLayout: Retrieves layout data based on the entity and layout type, specified in the route and query parameters respectively.
                                                                    *   The layout data is read from a YAML file and returned as JSON.
                                                                    */
    [Route("api/meta-data")]
    [Authorize]
    public class MetaDataController : ControllerBase
    {
        /// <summary>
        /// Retrieves and returns menu data
        /// </summary>
        /// <returns>Returns json.</returns>
        [HttpGet]
        [Route("menu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public IActionResult GetMenu()
        {
            string menuFilePath =  $"./Menu/Menu.yaml";
            var dynamicYaml = System.IO.File.ReadAllText(menuFilePath);
            var deserializer =  new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize<dynamic>(dynamicYaml);
            return Ok(yamlObject);
        }

        /// <summary>
        /// Retrieves and returns layout data based on entity and layout type.
        /// </summary>
        /// <param name="entity">Entity name</param>
        /// <param name="layoutType">Layout type as List= 1, Add= 2 and Edit= 3</param>
        /// <returns>Returns json.</returns>
        [HttpGet]
        [Route("{entity}/layout")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public IActionResult GetLayout([FromRoute] string entity, [FromQuery] LayoutType layoutType)
        {
            if (string.IsNullOrEmpty(entity))
            {
                return BadRequest("Entity should not be empty");
            }

            if (layoutType == 0)
            {
                return BadRequest("Entity's layout type should not be blank");
            }

            string type = "";
            switch (layoutType)
            {
                case LayoutType.List:
                    type = "List";
                    break;
                case LayoutType.Edit:
                    type = "Edit";
                    break;
                case LayoutType.Add:
                    type = "Add";
                    break;
            }

            if (string.IsNullOrEmpty(type))
            {
                return BadRequest("Invalid layout type");
            }

            string layoutFilePath = $"./Layout/{entity}/{type}.yaml";
            var dynamicYaml = System.IO.File.ReadAllText(layoutFilePath);
            var deserializer =  new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize<dynamic>(dynamicYaml);
            return Ok(yamlObject);
        }
    }
}