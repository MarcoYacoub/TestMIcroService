using Atc.CodeDocumentation.Markdown;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace TestMIcroService.APIControllers
{
    /// <summary>
    /// Values API controller 
    /// the follwoing methods are under the same class till you find this message again
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// This is a very simple method
        /// </summary>
        /// <params>
        ///     <param>
        ///         int x
        ///     </param>
        /// </params>
        /// <returns>0</returns>
        
        [HttpGet]
        //[Atc.LocalizedDescription("Index Method For Values Controller", typeof(ValuesController))]
        public int Index(int x)
        {
            var sourceAssembly = typeof(ValuesController).Assembly;
            var codeDocDirectory = new DirectoryInfo(@"C:\Users\Marco\source\repos\TestMIcroService\TestMIcroService");

            // Act
            MarkdownCodeDocGenerator.Run(sourceAssembly, codeDocDirectory);
            return 1;
            // Arrange
            
        }
    }
}
