import { AccountConfigModule } from '@abp/ng.account/config';
import { CoreModule } from '@abp/ng.core';
import { registerLocale } from '@abp/ng.core/locale';
import { IdentityConfigModule } from '@abp/ng.identity/config';
import { SettingManagementConfigModule } from '@abp/ng.setting-management/config';
import { TenantManagementConfigModule } from '@abp/ng.tenant-management/config';
import { InternetConnectionStatusComponent, ThemeSharedModule } from '@abp/ng.theme.shared';
import { importProvidersFrom, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { environment } from '../environments/environment';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { APP_ROUTE_PROVIDER } from './route.provider';
import { FeatureManagementModule } from '@abp/ng.feature-management';
import { AbpOAuthModule } from '@abp/ng.oauth';
import { ThemeBasicModule } from '@abp/ng.theme.basic';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { NgxValidateCoreModule } from '@ngx-validate/core';

@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    CoreModule.forRoot({
      environment,
      registerLocaleFn: registerLocale()
    }),
    AbpOAuthModule.forRoot(),
    ThemeSharedModule.forRoot(),
    NgxValidateCoreModule.forRoot({
    }),
    AccountConfigModule.forRoot(),
    IdentityConfigModule.forRoot(),
    TenantManagementConfigModule.forRoot(),
    SettingManagementConfigModule.forRoot(),
    FeatureManagementModule.forRoot(),
    InternetConnectionStatusComponent,
    ThemeBasicModule.forRoot()
  ],
  declarations: [AppComponent],
  providers: [APP_ROUTE_PROVIDER, provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
