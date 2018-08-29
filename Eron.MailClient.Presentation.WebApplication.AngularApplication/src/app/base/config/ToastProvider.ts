import { ToastOptions } from 'ng2-toastr';
import { CustomToastOption } from './custom.toastoption';

export class ToastProvider {
  public provide = ToastOptions;
  public useClass = CustomToastOption;

  forRoot() {
    return ;
  }
}
