using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);

            builder
                 .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Endereco) //associacao 1 -> n
                .WithOne(x => x.Cliente) //associacao 1 -> n
                .HasForeignKey<Endereco>(x => x.ClienteId); //associacao 1 -> n

            builder.Property(e => e.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
