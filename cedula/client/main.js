import { Template } from 'meteor/templating';
import { ReactiveVar } from 'meteor/reactive-var';

import './main.html';

Template.cedulaCheck.events({
  'click #checker'(event, instance) {
    // increment the counter when button is clicked
   var cedula = $("#cedulaNumber").val();
  
   cedula =cedula.replace(/-/g,"");
   cedula = cedula.replace(/_/g,"");
   cedula = cedula.replace(/ /g,"");

   var cedulaSize = $("#cedulaNumber").val();
  
   cedulaSize =cedulaSize.replace(/-/g,"");
   cedulaSize = cedulaSize.replace(/_/g,"");
   cedulaSize = cedulaSize.replace(/ /g,"");
  // console.log(cedulaSize.length);
   
   cedula= parseInt(cedula);


   if(typeof cedula =="number")
   {
        console.log("es un numero");
        if(cedulaSize.length ==11)
        {
          $("#resultado").val("Valida");
        }
        else
        {
          $("#resultado").val("Invalida");
        }
       }
        else
        {
          $("#resultado").val("Invalida");
        }
  

   
  },
});


