import $ from 'jquery';
import 'bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import './css/styles.css';
import { Entry } from './journal.js';

$(document).ready(function(){
  $('#journal-entry').submit(function(event) {
    event.preventDefault();
 
    $('input#title').val("");
    $('input#body').val("");
    const inputtedTitle = $('input#title').val();
    const inputtedBody = $('input#body').val();
    const entry = new Entry(title, body);
    const count = entry.wordCounter();
    $('#total-count').html(count);
    $("#total-count").show();
  })

});