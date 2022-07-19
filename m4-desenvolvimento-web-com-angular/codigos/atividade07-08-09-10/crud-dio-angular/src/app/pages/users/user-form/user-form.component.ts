import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/user';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css']
})
export class UserFormComponent implements OnInit {

  useForm: FormGroup;
  users: Array<User> = [];
  userId: any = '';
  num!: number;

  constructor(private fb: FormBuilder,
    private userService: UserService,
    private actRoute: ActivatedRoute,
    private router: Router) {
    this.useForm = fb.group({
      id: 0,
      nome: '',
      sobrenome: '',
      idade: this.num,
      profissao: '',
    })
  }

  ngOnInit(): void {
    this.actRoute.paramMap.subscribe(params => {
      this.userId = params.get('id')
      console.log(this.userId)
      if(this.userId !== null) {
        this.userService.getUser(this.userId).subscribe(result => {
          this.useForm.patchValue({
            id: result[0].id,
            nome: result[0].nome,
            sobrenome: result[0].sobrenome,
            idade: result[0].idade,
            profissao: result[0].profissao,
          })
        })
      }
    })

    this.getUsers();
  }

  getUsers(): void {
    this.userService.getUsers().subscribe(response => {
      this.users = response;
    })
  }

  createUser() {
    this.useForm.get('id')?.patchValue(this.users.length + 1);
    this.userService.postUser(this.useForm.value).subscribe((result) => {
      console.log(`Usuário ${result.nome} cadastrado com sucesso!`)
      console.log(result);
    }, (err) => {
      console.log(err);
    }, () => {
      this.router.navigate(['/']);
    })
  }

  updateUser() {
    this.userService.updateUser(this.userId, this.useForm.value).subscribe(result => {
      console.log('usuário atualizado', result)
    }, (err) => {
      console.log(err);
    }, () => {
      this.router.navigate(['/']);
    })
  }

  actionButton() {
    if(this.userId !== null) {
      this.updateUser();
    } else {
      this.createUser();
    }
  }

}
