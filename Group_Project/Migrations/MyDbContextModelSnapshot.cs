// <auto-generated />
using System;
using Group_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroupProject.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Group_Project.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandlineNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MidleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NativeLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PhotoIdIssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoIdType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("Group_Project.Models.CandidateCertificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("CandidateCertificate");
                });

            modelBuilder.Entity("Group_Project.Models.CandidateExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("ExamId");

                    b.ToTable("CandidateExam");
                });

            modelBuilder.Entity("Group_Project.Models.CandidateExamQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateExamId")
                        .HasColumnType("int");

                    b.Property<int>("ExamAnswer")
                        .HasColumnType("int");

                    b.Property<int>("ExamQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateExamId");

                    b.HasIndex("ExamQuestionId");

                    b.ToTable("CandidateExamQuestions");
                });

            modelBuilder.Entity("Group_Project.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("Group_Project.Models.ExamQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidatesAnswer")
                        .HasColumnType("int");

                    b.Property<int>("ExamTopicsId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamTopicsId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("Group_Project.Models.ExamTopics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("TopicId");

                    b.ToTable("ExamTopics");
                });

            modelBuilder.Entity("Group_Project.Models.Exams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Group_Project.Models.PosibleAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PosibleAnswers");
                });

            modelBuilder.Entity("Group_Project.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PosibleAnswersId")
                        .HasColumnType("int");

                    b.Property<string>("TextOfQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PosibleAnswersId");

                    b.HasIndex("TopicsId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Group_Project.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CertificateId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectWeight")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Group_Project.Models.CandidateCertificate", b =>
                {
                    b.HasOne("Group_Project.Models.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group_Project.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Certificate");
                });

            modelBuilder.Entity("Group_Project.Models.CandidateExam", b =>
                {
                    b.HasOne("Group_Project.Models.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group_Project.Models.Exams", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("Group_Project.Models.CandidateExamQuestions", b =>
                {
                    b.HasOne("Group_Project.Models.CandidateExam", "CandidateExam")
                        .WithMany()
                        .HasForeignKey("CandidateExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group_Project.Models.ExamQuestions", "ExamQuestion")
                        .WithMany()
                        .HasForeignKey("ExamQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CandidateExam");

                    b.Navigation("ExamQuestion");
                });

            modelBuilder.Entity("Group_Project.Models.ExamQuestions", b =>
                {
                    b.HasOne("Group_Project.Models.ExamTopics", "ExamTopics")
                        .WithMany()
                        .HasForeignKey("ExamTopicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group_Project.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExamTopics");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Group_Project.Models.ExamTopics", b =>
                {
                    b.HasOne("Group_Project.Models.Exams", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group_Project.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Group_Project.Models.Exams", b =>
                {
                    b.HasOne("Group_Project.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certificate");
                });

            modelBuilder.Entity("Group_Project.Models.Question", b =>
                {
                    b.HasOne("Group_Project.Models.PosibleAnswers", "PosibleAnswers")
                        .WithMany()
                        .HasForeignKey("PosibleAnswersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group_Project.Models.Topic", "Topics")
                        .WithMany("Questions")
                        .HasForeignKey("TopicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PosibleAnswers");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("Group_Project.Models.Topic", b =>
                {
                    b.HasOne("Group_Project.Models.Certificate", null)
                        .WithMany("Topics")
                        .HasForeignKey("CertificateId");
                });

            modelBuilder.Entity("Group_Project.Models.Certificate", b =>
                {
                    b.Navigation("Topics");
                });

            modelBuilder.Entity("Group_Project.Models.Topic", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
