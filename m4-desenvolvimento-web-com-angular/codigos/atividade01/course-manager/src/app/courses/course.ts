export class Course {
  [x: string]: any;
  id: number;
  name: string;
  imageUrl: string;
  price: number;
  code: string;
  duration: number;
  releaseDate: string;
  description: string;
  rating: number;

  constructor (id:number, name: string, imageUrl: string, price: number, code: string, duration: number, rating: number, releaseDate: string, description:string) {
    this.id = id;
    this.name = name;
    this.imageUrl = imageUrl;
    this.price = price;
    this.code = code;
    this.duration = duration;
    this.releaseDate = releaseDate;
    this.rating = rating;
    this.description = description;
  }
}
