import { Component } from '@angular/core';
import {Panel} from "primeng/panel";
import {ContactComponent} from "../contact/contact.component";
import {ButtonModule} from "primeng/button";

@Component({
  selector   : 'app-home',
  templateUrl: './home.component.html',
  imports: [
    Panel,
    ContactComponent,
    ButtonModule
  ],
  styleUrl   : './home.component.css'
})
export class HomeComponent {

}
