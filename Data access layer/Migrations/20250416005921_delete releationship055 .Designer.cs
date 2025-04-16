﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data_access_layer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250416005921_delete releationship055 ")]
    partial class deletereleationship055
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data_access_layer.model.Assignment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonID")
                        .HasColumnType("int");

                    b.Property<decimal>("MaxGrade")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("LessonID");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Data_access_layer.model.Choice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MCQQuestionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MCQQuestionID");

                    b.ToTable("Choice");
                });

            modelBuilder.Entity("Data_access_layer.model.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InstructorID")
                        .HasColumnType("int");

                    b.Property<int>("LessonID")
                        .HasColumnType("int");

                    b.Property<string>("Reply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("InstructorID");

                    b.HasIndex("LessonID");

                    b.HasIndex("StudentID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Data_access_layer.model.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Data_access_layer.model.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsTimed")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxGrade")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Data_access_layer.model.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Qualifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Data_access_layer.model.Lesson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("SupportingFiles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("VideoURL")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("num_of_views")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Data_access_layer.model.MCQ", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID")
                        .IsUnique();

                    b.ToTable("MCQ");
                });

            modelBuilder.Entity("Data_access_layer.model.Questions", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionID"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("QuestionID");

                    b.HasIndex("AssignmentID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Data_access_layer.model.Revision", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduleDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupportingFiles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("VideoURL")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Revisions");
                });

            modelBuilder.Entity("Data_access_layer.model.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("GradeLevel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("fatherPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Data_access_layer.model.Student_Assignment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Grade")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubmittedFiles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentAssignments");
                });

            modelBuilder.Entity("Data_access_layer.model.Student_Exam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ExamID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentExams");
                });

            modelBuilder.Entity("Data_access_layer.model.Written", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID")
                        .IsUnique();

                    b.ToTable("Written");
                });

            modelBuilder.Entity("Data_access_layer.model.assignment_Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("assignment_question_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.HasIndex("assignment_question_id");

                    b.ToTable("AssignmentAnswers");
                });

            modelBuilder.Entity("Data_access_layer.model.assignment_question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AssignmentID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("mark")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("QuestionID");

                    b.ToTable("AssignmentQuestions");
                });

            modelBuilder.Entity("Data_access_layer.model.examQuestion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<decimal>("mark")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ExamID");

                    b.HasIndex("QuestionID");

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("Data_access_layer.model.student_Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Data_access_layer.model.student_answers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionsQuestionID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("examQuestionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionsQuestionID");

                    b.HasIndex("StudentID");

                    b.HasIndex("examQuestionID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Data_access_layer.model.Assignment", b =>
                {
                    b.HasOne("Data_access_layer.model.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.Lesson", "Lesson")
                        .WithMany("Assignments")
                        .HasForeignKey("LessonID");

                    b.Navigation("Course");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Data_access_layer.model.Choice", b =>
                {
                    b.HasOne("Data_access_layer.model.MCQ", "MCQ")
                        .WithMany("Choices")
                        .HasForeignKey("MCQQuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MCQ");
                });

            modelBuilder.Entity("Data_access_layer.model.Comment", b =>
                {
                    b.HasOne("Data_access_layer.model.Instructor", "Instructor")
                        .WithMany("Comments")
                        .HasForeignKey("InstructorID");

                    b.HasOne("Data_access_layer.model.Lesson", "Lesson")
                        .WithMany("Comment")
                        .HasForeignKey("LessonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.Student", "Student")
                        .WithMany("Comments")
                        .HasForeignKey("StudentID");

                    b.Navigation("Instructor");

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data_access_layer.model.Exam", b =>
                {
                    b.HasOne("Data_access_layer.model.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data_access_layer.model.Lesson", b =>
                {
                    b.HasOne("Data_access_layer.model.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data_access_layer.model.MCQ", b =>
                {
                    b.HasOne("Data_access_layer.model.Questions", "Question")
                        .WithOne("MCQ")
                        .HasForeignKey("Data_access_layer.model.MCQ", "QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Data_access_layer.model.Questions", b =>
                {
                    b.HasOne("Data_access_layer.model.Assignment", "Assignment")
                        .WithMany()
                        .HasForeignKey("AssignmentID");

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("Data_access_layer.model.Revision", b =>
                {
                    b.HasOne("Data_access_layer.model.Course", "Course")
                        .WithMany("Revisions")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data_access_layer.model.Student_Assignment", b =>
                {
                    b.HasOne("Data_access_layer.model.Assignment", "Assignment")
                        .WithMany("Student_Assignment")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.Student", "Student")
                        .WithMany("Student_Assignment")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data_access_layer.model.Student_Exam", b =>
                {
                    b.HasOne("Data_access_layer.model.Exam", "Exam")
                        .WithMany("StudentExams")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.Student", "Student")
                        .WithMany("Student_Exam")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data_access_layer.model.Written", b =>
                {
                    b.HasOne("Data_access_layer.model.Questions", "Question")
                        .WithOne("Written")
                        .HasForeignKey("Data_access_layer.model.Written", "QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Data_access_layer.model.assignment_Answer", b =>
                {
                    b.HasOne("Data_access_layer.model.Student", "Student")
                        .WithMany("assignment_Answer")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.assignment_question", "assignment_question")
                        .WithMany("Answers")
                        .HasForeignKey("assignment_question_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("assignment_question");
                });

            modelBuilder.Entity("Data_access_layer.model.assignment_question", b =>
                {
                    b.HasOne("Data_access_layer.model.Assignment", "Assignment")
                        .WithMany("assignment_Question")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.Questions", "Question")
                        .WithMany("AssignmentQuestions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Data_access_layer.model.examQuestion", b =>
                {
                    b.HasOne("Data_access_layer.model.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.Questions", "Question")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Data_access_layer.model.student_Course", b =>
                {
                    b.HasOne("Data_access_layer.model.Course", "Course")
                        .WithMany("student_Course")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.Student", "Student")
                        .WithMany("student_Course")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data_access_layer.model.student_answers", b =>
                {
                    b.HasOne("Data_access_layer.model.Questions", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionsQuestionID");

                    b.HasOne("Data_access_layer.model.Student", "Student")
                        .WithMany("Answers")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_access_layer.model.examQuestion", "examQuestion")
                        .WithMany("Answers")
                        .HasForeignKey("examQuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("examQuestion");
                });

            modelBuilder.Entity("Data_access_layer.model.Assignment", b =>
                {
                    b.Navigation("Student_Assignment");

                    b.Navigation("assignment_Question");
                });

            modelBuilder.Entity("Data_access_layer.model.Course", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Exams");

                    b.Navigation("Lessons");

                    b.Navigation("Revisions");

                    b.Navigation("student_Course");
                });

            modelBuilder.Entity("Data_access_layer.model.Exam", b =>
                {
                    b.Navigation("ExamQuestions");

                    b.Navigation("StudentExams");
                });

            modelBuilder.Entity("Data_access_layer.model.Instructor", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Data_access_layer.model.Lesson", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("Data_access_layer.model.MCQ", b =>
                {
                    b.Navigation("Choices");
                });

            modelBuilder.Entity("Data_access_layer.model.Questions", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("AssignmentQuestions");

                    b.Navigation("ExamQuestions");

                    b.Navigation("MCQ")
                        .IsRequired();

                    b.Navigation("Written")
                        .IsRequired();
                });

            modelBuilder.Entity("Data_access_layer.model.Student", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Comments");

                    b.Navigation("Student_Assignment");

                    b.Navigation("Student_Exam");

                    b.Navigation("assignment_Answer");

                    b.Navigation("student_Course");
                });

            modelBuilder.Entity("Data_access_layer.model.assignment_question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Data_access_layer.model.examQuestion", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
