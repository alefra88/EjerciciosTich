document.addEventListener('DOMContentLoaded', function() {
    deshabCampos();
   
    })

      // Evento click del botón Consultar/Guardar
      document.getElementById('btnConsultar').addEventListener('click', function(e) {
        var id = document.getElementById('inputId').value.trim();
        e.preventDefault();

        if (document.getElementById('btnConsultar').textContent === 'Consultar') {
            // Si está en modo consultar
            if (id === '') {
                alert('Ingresa un valor en el campo ID');
            } else {
                var datosEstaticos = {
                    nombre: 'Alan',
                    edad: '36',
                    estatus: true,
                    estado: 'Guerrero' // Cambiado a un valor estático directo
                };

                habCampos();

                // Asignar valores a los campos
                document.getElementById('inputNombre').value = datosEstaticos.nombre;
                document.getElementById('inputEdad').value = datosEstaticos.edad;
                document.getElementById('estados').value = datosEstaticos.estado;
                document.getElementById('checkbox').checked = datosEstaticos.estatus;
                document.getElementById('inputId').disabled = true;
            }
        } else {
            // Si está en modo guardar (limpiar y deshabilitar)
            limpiar();
            deshabCampos();
        }
    });

   
    // Función para deshabilitar todos los campos
    function deshabCampos() {
        document.getElementById('inputNombre').disabled = true;
        document.getElementById('inputEdad').disabled = true;
        document.getElementById('estados').disabled = true;
        document.getElementById('checkbox').disabled = true;
        document.getElementById('btnConsultar').textContent = "Consultar";
    }

    // Función para habilitar todos los campos
    function habCampos() {
        document.getElementById('inputNombre').disabled = false;
        document.getElementById('inputEdad').disabled = false;
        document.getElementById('estados').disabled = false;
        document.getElementById('checkbox').disabled = false;
        document.getElementById('btnConsultar').textContent = "Guardar";
    }

    function limpiar(){
        document.getElementById('inputNombre').value = '';
            document.getElementById('inputEdad').value = '';
            document.getElementById('estados').value = '';
            document.getElementById('checkbox').checked = false;
            document.getElementById('inputId').disabled = false;
    }

