// q1: ¿Qué es el DOM?



// q2: ¿Qué es un nodo?
// 


// q3: ¿Cómo se accede a un elemento del DOM?
// 


// q4: ¿Cómo se modifica un elemento del DOM?



// q5: ¿Cuál es la diferencia entre getElementby* y querySelector*?


// q6: ¿Qué es un evento?



// q7: ¿Qué es un listener?



// q8: ¿Qué es un callback?



// q9: ¿Qué es un objeto de evento?


// Obtener el elemento del DOM
// const mousePosition = document.getElementById("mousePosition");

// // Agregar un evento de movimiento al documento
// document.addEventListener("mousemove", (event) => {
//   // Actualizar el contenido del elemento con la posición del mouse
//   mousePosition.textContent = `Posición del mouse: ${event.clientX}, ${event.clientY}`;
// });


// Función para actualizar la posición del mouse en el elemento HTML

document.addEventListener('mousemove', updatePosition);
  function updatePosition(event) {
   const mousePosition = document.getElementById("mousePosition");
   mousePosition.textContent = `Posición del mouse: ${event.clientX}, ${event.clientY}`;
 }


 
const form = document.getElementById("form1");
    const submitButton = document.getElementById("form1-submit");

    submitButton.addEventListener("click", (event) => {
      event.preventDefault(); // prevenir la acción predeterminada del botón de envío
      
      // obtener valores de entrada de nombre y apellido
      const fname = document.getElementById("form-fname").value;
      const lname = document.getElementById("form-lname").value;
      
      // concatenar el nombre completo y agregarlo como un nuevo elemento
      const fullName = fname + " " + lname;
      const fullNameElement = document.createElement("p");
      fullNameElement.innerText = fullName;
      document.getElementById("form1").insertAdjacentElement("afterend", fullNameElement);
    });



const insertRowBtn = document.getElementById("btn-insert-r");
const table = document.getElementById("sampleTable");

insertRowBtn.addEventListener("click", function() {
  const newRow = table.insertRow();
  const newCell1 = newRow.insertCell();
  const newCell2 = newRow.insertCell();
  newCell1.innerHTML = "New row column 1";
  newCell2.innerHTML = "New row column 2";
});


const insertColBtn = document.getElementById("btn-insert-c");

insertColBtn.addEventListener("click", function() {
  const rows = table.rows;
  for (let i = 0; i < rows.length; i++) {
    const cell = rows[i].insertCell();
    cell.innerHTML = "New column";
  }
});


// Obtener la referencia a los elementos del DOM
const rowIndex = document.getElementById('rowIndex');
const colIndex = document.getElementById('colIndex');
const newValue = document.getElementById('newValue');
const btnChange = document.getElementById('btn-change');
const table1 = document.getElementById('myTable');

// Agregar el evento click al botón
btnChange.addEventListener('click', function() {
  // Obtener los valores de las cajas de texto
  const row = parseInt(rowIndex.value);
  const col = parseInt(colIndex.value);
  const value = newValue.value;

  // Obtener la referencia a la celda que se quiere modificar
  const targetCell = table1.rows[row].cells[col];

  // Actualizar el contenido de la celda
  targetCell.innerHTML = value;
});

const colorSelect = document.getElementById('colorSelect');
    const addColorBtn = document.getElementById('btn-add-color');
    const removeColorBtn = document.getElementById('btn-rmv-color');

    addColorBtn.addEventListener('click', () => {
        const randomColor = Math.floor(Math.random()*16777215).toString(16);
        const newColorOption = document.createElement('option');
        newColorOption.text = "#" + randomColor;
        colorSelect.add(newColorOption);
    });

    removeColorBtn.addEventListener('click', () => {
        colorSelect.remove(colorSelect.selectedIndex);
    });


      // Obtenemos la imagen y agregamos el evento mouseover
  const imagen = document.getElementById("imagenGato");
  imagen.addEventListener("mouseover", function() {
    // Generamos los números aleatorios entre 300 y 600
    const width = Math.floor(Math.random() * 301) + 300;
    const height = Math.floor(Math.random() * 301) + 300;
    // Actualizamos los atributos width, height y src de la imagen con los valores generados
    imagen.setAttribute("width", width);
    imagen.setAttribute("height", height);
    imagen.setAttribute("src", `http://placekitten.com/${width}/${height}`);
  });