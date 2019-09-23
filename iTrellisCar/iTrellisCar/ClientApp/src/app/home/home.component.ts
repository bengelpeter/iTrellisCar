
import { HttpClient, HttpHeaders } from '@angular/common/http'; // Import it up here
import { FormsModule, FormGroup, FormControl } from '@angular/forms';
import { Component, OnInit, Inject, Injectable } from '@angular/core';
import { NgForm, FormBuilder } from '@angular/forms';
import { AppModule } from '../app.module';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})

@Injectable()
export class HomeComponent  {
  public Cars: Car[];
  private regForm: any;
  refForm: FormGroup;   // Define our from group

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private formBuilder: FormBuilder) {
    http.get<Car[]>(baseUrl + 'api/SampleData/ReturnCar').subscribe(result => {   
      this.Cars = result as Car [];
    }, error => console.error(error));

  }

  ngOnInit() {
    this.regForm = new FormGroup({
      color: new FormControl(),
      sun: new FormControl(),
      four: new FormControl(),
      low: new FormControl(),
      power: new FormControl(),
      navigation: new FormControl(),
      heated: new FormControl()
    })
  }


  onSubmit(form: NgForm) {
    this.http.get<Car[]>('api/SampleData/ReturnCar?Color=' + form.value.color
      + "&hasSunroof=" + form.value.sun
      + "&isFourWheelDrive=" + form.value.four
      + "&hasLowMiles=" + form.value.low
      + "&hasPowerWindows=" + form.value.power
      + "&hasNavigation=" + form.value.navigation
      + "&hasHeatedSeats=" + form.value.heated).subscribe(result => {
      this.Cars = result as Car[];
    }, error => console.error(error));

  }
  

}
interface Car {
  _id: string;
  make: string;
  year: string;
  color: string;
  price: number;
  hasSunroof: boolean;
  isFourWheelDrive: boolean;
  hasLowMiles: boolean;
  hasPowerWindows: boolean;
  hasNavigation: boolean;
  hasHeatedSeats: boolean;
}
