using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_LAB02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {




        // GET api/<moviesController>/inorder
        [HttpGet("{traversal}")]
    /*    public ActionResult GetByDate([FromRoute] string traversal)
        {
            try
            {
                if (Storage.MoviesTree.MultiwayPeli != null)
                {
                    traversal = traversal.ToLower();
                    List<mMovies> Result = new List<mMovies>();
                    if (traversal.Equals("preorder"))
                    {
                        Result = Storage.MoviesTree.MultiwayPeli.Preorder();
                    }
                    else if (traversal.Equals("inorder"))
                    {
                        Result = Storage.MoviesTree.MultiwayPeli.Inorder();
                    }
                    else if (traversal.Equals("postorder"))
                    {
                        Result = Storage.MoviesTree.MultiwayPeli.Postorder();
                    }
                    return Created("", Result);
                }
                else
                {
                    return Ok("Data export failed");
                }
            }
            catch
            {
                return Ok("Data export failed");
            }
        }
     */
        //Post para recibir el orden del MultiWayTree
        [HttpPost]
    /*    public ActionResult Post([FromBody] mTree Tree)
        {
            try
            {
                if (!(Tree.Order < 1))
                {

                    Storage.MoviesTree.Order = Tree.Order;
                    Storage.MoviesTree.MultiwayPeli = new Laboratorio1_ED2.MultiwayTree<mMovies>();
                    Storage.MoviesTree.MultiwayPeli.SetM(Tree.Order);
                    return Ok("El orden del árbol es:" + Tree.Order);
                }
                else
                {
                    return Ok("El orden debe ser mayor a 1");
                }
            }
            catch
            {
                return BadRequest();
            }
        }
    */

        // GET: api/<moviesController>
        [HttpPost("populate")]
        /*   public ActionResult Post([FromBody] List<mMovies> movList)
           {
               try
               {
                   if (Storage.MoviesTree.MultiwayPeli != null)
                   {
                       foreach (mMovies pelicula in movList)
                       {
                           Storage.MoviesTree.MultiwayPeli.InsertMultiWay(pelicula);
                       }
                       return Ok("OK");
                   }
                   return Ok("InternalServerError");
               }
               catch (Exception ex)
               {
                   return BadRequest();
               }
           }
        */

        // DELETE api/<MoviesController>/5
        [HttpDelete()]
        public void Delete()
        {
            //Eliminar el arbol :V
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
         //Se busca el elemento
         //Se elimina
         //Arbol.Delete(int id)
        }
    }
}
