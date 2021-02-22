import { Component, OnInit } from '@angular/core';
import { Course } from './course';

@Component({
  selector: 'app-course-list',
  templateUrl: './course-list.component.html'
})
export class CourseListComponent implements OnInit{
  courses: Course[] = [];

  ngOnInit(): void{
    this.courses = [
      {
        id: 1,
        name: 'Angular: Forms',
        imageUrl: '/assets/img/forms.png',
        price: 99.99,
        code: 'XPS-8796',
        duration: 126,
        rating: 4.5,
        releaseDate: 'November, 9, 2020'
      },
      {
        id: 2,
        name: 'Angular: STTP',
        imageUrl: '/assets/img/http.png',
        price: 45.99,
        code: 'LKL-1096',
        duration: 456,
        rating: 4,
        releaseDate: 'April, 20, 2018'
      },
    ]
  }
}
