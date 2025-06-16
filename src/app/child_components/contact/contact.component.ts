import { Component } from '@angular/core';
import {Divider} from "primeng/divider";

@Component({
  selector   : 'app-contact',
  templateUrl: './contact.component.html',
  imports    : [
    Divider
  ],
  styleUrl   : './contact.component.css'
})
export class ContactComponent {
  email = "harusho@harusho.slmail.me";
}
