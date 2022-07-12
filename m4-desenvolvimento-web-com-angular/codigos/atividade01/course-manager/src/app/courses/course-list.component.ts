import { Component, OnInit } from "@angular/core";
import { Course } from "./course";
import { CourseService } from "./course.service";

@Component({
//  selector: 'app-course-list', // foi retirado, pois será usado as rotas p/ fazer isso
  templateUrl: './course-list.component.html'
})
export class CourseListComponent implements OnInit {

  filteredCourses: Course[] = [];

  _courses: Course[] = [];

  // o _ serve para avisar outros dev, q posaam vir a ler o código, q essa var só fique no componente
  _filterBy!: string;


  constructor(private courseService: CourseService) { }

  ngOnInit(): void {
    this.retrieveAll();
  }

  retrieveAll(): void {
    this.courseService.retrieveAll().subscribe({
      next: courses => {
        this._courses = courses;
        this.filteredCourses = this._courses;
      },
      error: err => console.log('Error', err)
    })
  }

  deleteById(courseId: number): void {
    this.courseService.deleteByID(courseId).subscribe({
      next: () => {
        console.log('Delete with success');
        this.retrieveAll();
      },
      error: err => console.log('Error ', err)
    })
  }

  set filter(value: string) {
    this._filterBy = value;

    this.filteredCourses = this._courses.filter((course: Course) => course.name.toLocaleLowerCase().indexOf(this._filterBy.toLocaleLowerCase()) > -1)
  }

  get filter() {
    return this._filterBy;
  }


}
