import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Course } from './course';
import { CourseService } from './course.service';

@Component({
  templateUrl: '/course-info.component.html'
})
export class CourseInfoComponent implements OnInit{
  course: Course;
  constructor(private activatedRoute: ActivatedRoute, private courseService: CourseService){}

  ngOnInit(): void{
    this.courseService.retriveById(+this.activatedRoute.snapshot.paramMap.get('id')).subscribe({
      next: courses => this.course = courses,
      error: err => console.log('Error', err)
    });
  }
  save(): void{
    this.courseService.save(this.course).subscribe({
      next: courses => console.log(`Saved with success!`, courses),
      error: err => console.log(`Error`, err)
    });
  }
}
