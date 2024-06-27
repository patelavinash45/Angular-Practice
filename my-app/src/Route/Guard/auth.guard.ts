import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { ShowToasterService } from '../../Services/show-toaster.service';

export const authGuard: CanActivateFn = (route, state) => {
  const token = localStorage.getItem('jwtToken');
  if (token != null) {
    return true;
  }
  const router = inject(Router);
  const toaster = inject(ShowToasterService);
  toaster.showErrorMessage("Authorization Token Missing.");
  router.navigate(['/LogIn']);
  return false;
};
