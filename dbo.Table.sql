CREATE TABLE [StudentCourse]
(
	[StudentId] BIGINT NOT NULL,
	[CourseId] BIGINT NOT NULL, 
	PRIMARY key ([StudentId],[CourseId]),
    Foreign Key (StudentId) REFERENCES Student,
	Foreign Key (CourseId) REFERENCES Course,
)
