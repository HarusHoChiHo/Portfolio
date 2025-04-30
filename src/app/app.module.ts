import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AboutComponent} from "./child_components/about/about.component";
import {ContactComponent} from "./child_components/contact/contact.component";
import {HomeComponent} from "./child_components/home/home.component";

@NgModule({
    declarations: [
        AboutComponent,
        ContactComponent,
        HomeComponent
    ],
    imports     : [
        BrowserModule,
    ],
})
export class AppModule {
}
