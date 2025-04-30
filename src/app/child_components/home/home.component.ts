import { Component } from '@angular/core';
import {Panel} from "primeng/panel";
import {ContactComponent} from "../contact/contact.component";

@Component({
  selector   : 'app-home',
  templateUrl: './home.component.html',
  imports: [
    Panel,
    ContactComponent
  ],
  styleUrl   : './home.component.css'
})
export class HomeComponent {

}
