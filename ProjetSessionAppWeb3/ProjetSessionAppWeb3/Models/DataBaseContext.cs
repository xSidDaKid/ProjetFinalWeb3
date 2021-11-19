using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("message");

                entity.HasKey(m => m.IdMessage)
                .HasName("PRIMARY");

                entity.HasIndex(m => m.IdUser, "FK_UserMessageConstraint");

                entity.HasIndex(m => m.IdChat, "FK_ChatMessageConstraint");

                entity.Property(m => m.IdMessage)
                .HasColumnName("idMessage")
                .IsRequired();

                entity.Property(m => m.IdUser)
                .HasColumnName("idUser")
                .IsRequired();

                entity.Property(m => m.IdChat)
                .HasColumnName("idChat")
                .IsRequired();

                entity.Property(m => m.Username)
                .HasColumnName("username")
                .HasMaxLength(25)
                .IsRequired();

                entity.Property(m => m.DateMessaged)
                .HasColumnName("dateMessaged")
                .IsRequired();

                entity.Property(m => m.Description)
                .HasColumnName("description")
                .IsRequired();
                
                //Les relations de Message

                entity.HasOne<User>(m => m.IdUserReference)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.IdUser)
                .HasConstraintName("FK_UserMessageConstraint")
                .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne<Chat>(m => m.IdChatReference)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.IdChat)
                .HasConstraintName("FK_ChatMessageConstraint")
                .OnDelete(DeleteBehavior.SetNull);

            });

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.ToTable("chat");

                entity.HasKey(c => c.IdChat)
                .HasName("PRIMARY");

                entity.HasIndex(c => c.IdCreator, "FK_ChatCreatorConstraint");

                entity.Property(c => c.IdChat)
                .HasColumnName("idChat")
                .IsRequired();

                entity.Property(c => c.ChatName)
                .HasColumnName("chatName")
                .HasMaxLength(50)
                .IsRequired();

                entity.Property(c => c.IdCreator)
                .HasColumnName("idCreator")
                .IsRequired();

                //Relation chat a un creator, mais creator peut avoir plusieurs chat
                entity.HasOne(c => c.IdCreatorReference)
                .WithMany(u => u.Chats)
                .HasForeignKey(c => c.IdCreator)
                .HasConstraintName("FK_ChatCreatorConstraint")
                .OnDelete(DeleteBehavior.SetNull);

            });

            modelBuilder.Entity<User>(entity =>
            { });

            modelBuilder.Entity<UserChat>(entity =>
            { });

        }

    }
}
