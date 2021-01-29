using System;
using System.Collections.Generic;
using System.Text;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CursoTest
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
        public CategoriasControllerTest()
        {

        }
    }
}
