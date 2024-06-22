import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { AbpInfoComponent } from './abp-info.component';
import { SimpleFormComponent } from './simple-form/simple-form.component';

@NgModule({
  declarations: [HomeComponent,AbpInfoComponent],
  imports: [SharedModule, HomeRoutingModule, SimpleFormComponent],
})
export class HomeModule {}
