using Microsoft.EntityFrameworkCore;
using System;

namespace ProjetoEducar.Infra.Dados
{
    public class ContextoDB : DbContext
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {
        }

    }
}
