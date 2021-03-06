﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ObjectsImageRecognitionLibrary;

namespace ImageRecognitionLibrary.Migrations
{
    [DbContext(typeof(ModelContext))]
    partial class ModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ObjectsImageRecognitionLibrary.Blob", b =>
                {
                    b.Property<int>("BlobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ImageContext")
                        .HasColumnType("BLOB");

                    b.HasKey("BlobId");

                    b.ToTable("ImageContext");
                });

            modelBuilder.Entity("ObjectsImageRecognitionLibrary.ClassLabel", b =>
                {
                    b.Property<int>("ClassLabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassLabelImagesNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StringClassLabel")
                        .HasColumnType("TEXT");

                    b.HasKey("ClassLabelId");

                    b.ToTable("ClassLabels");
                });

            modelBuilder.Entity("ObjectsImageRecognitionLibrary.ImageInformation", b =>
                {
                    b.Property<int>("ImageInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClassLabelId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ImageContextBlobId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<float>("Probability")
                        .HasColumnType("REAL");

                    b.HasKey("ImageInformationId");

                    b.HasIndex("ClassLabelId");

                    b.HasIndex("ImageContextBlobId");

                    b.ToTable("ImagesInformation");
                });

            modelBuilder.Entity("ObjectsImageRecognitionLibrary.ImageInformation", b =>
                {
                    b.HasOne("ObjectsImageRecognitionLibrary.ClassLabel", "ClassLabel")
                        .WithMany("ImagesInformation")
                        .HasForeignKey("ClassLabelId");

                    b.HasOne("ObjectsImageRecognitionLibrary.Blob", "ImageContext")
                        .WithMany()
                        .HasForeignKey("ImageContextBlobId");

                    b.Navigation("ClassLabel");

                    b.Navigation("ImageContext");
                });

            modelBuilder.Entity("ObjectsImageRecognitionLibrary.ClassLabel", b =>
                {
                    b.Navigation("ImagesInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
