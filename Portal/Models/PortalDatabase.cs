namespace Portal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PortalDatabase : DbContext
    {
        public PortalDatabase()
            : base("PortalDatabase")
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<CMS_Category> CMS_Category { get; set; }
        public virtual DbSet<CMSPage> CMSPages { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<ELMAH_Error> ELMAH_Error { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<GalleryType> GalleryTypes { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<NoticeBoard> NoticeBoards { get; set; }
        public virtual DbSet<Reg_Courses> Reg_Courses { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .Property(e => e.AnsDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<CMS_Category>()
                .HasMany(e => e.CMSPages)
                .WithRequired(e => e.CMS_Category)
                .HasForeignKey(e => e.CMSCategory_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CMSPage>()
                .Property(e => e.CMSPageContent)
                .IsUnicode(false);

            modelBuilder.Entity<CMSPage>()
                .Property(e => e.CMSPageHeading)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.CourseCode)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Exams)
                .WithOptional(e => e.Course)
                .HasForeignKey(e => e.Course_Id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Lectures)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Reg_Courses)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.Feedback)
                .HasForeignKey(e => e.Feedback_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gallery>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Gallery>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Gallery>()
                .Property(e => e.FriendlyName)
                .IsUnicode(false);

            modelBuilder.Entity<GalleryType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<GalleryType>()
                .HasMany(e => e.Galleries)
                .WithRequired(e => e.GalleryType)
                .HasForeignKey(e => e.Type_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.FileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<NoticeBoard>()
                .Property(e => e.NewsHeading)
                .IsUnicode(false);

            modelBuilder.Entity<NoticeBoard>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<NoticeBoard>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.SectionName)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Exams)
                .WithOptional(e => e.Section)
                .HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Lectures)
                .WithRequired(e => e.Section)
                .HasForeignKey(e => e.Section_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Timetables)
                .WithRequired(e => e.Section)
                .HasForeignKey(e => e.Section_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Section)
                .HasForeignKey(e => e.Section_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Teachers)
                .WithMany(e => e.Sections)
                .Map(m => m.ToTable("TeacherSection").MapLeftKey("Section_Id").MapRightKey("Teacher_Id"));

            modelBuilder.Entity<Semester>()
                .Property(e => e.SemesterName)
                .IsUnicode(false);

            modelBuilder.Entity<Semester>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Semester)
                .HasForeignKey(e => e.Semester_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semester>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Semester)
                .HasForeignKey(e => e.Semester_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.RegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FatherName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.CNIC)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LandlineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Reg_Courses)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.Student_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.CNIC)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Qulification)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.LandlineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Passwrd)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.Teacher_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Lectures)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.Teacher_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Reg_Courses)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.Teacher_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Students)
                .WithMany(e => e.Teachers)
                .Map(m => m.ToTable("StudentTeacher").MapLeftKey("Teacher_Id").MapRightKey("Student_Id"));

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Day)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period1)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period2)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period3)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period4)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period5)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period6)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period7)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period8)
                .IsUnicode(false);

            modelBuilder.Entity<Timetable>()
                .Property(e => e.Period9)
                .IsUnicode(false);
        }
    }
}
