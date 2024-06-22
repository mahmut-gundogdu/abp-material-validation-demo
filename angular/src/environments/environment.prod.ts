import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BookStoreMaterial',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44399/',
    redirectUri: baseUrl,
    clientId: 'BookStoreMaterial_App',
    responseType: 'code',
    scope: 'offline_access BookStoreMaterial',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44399',
      rootNamespace: 'BookStoreMaterial',
    },
  },
} as Environment;
