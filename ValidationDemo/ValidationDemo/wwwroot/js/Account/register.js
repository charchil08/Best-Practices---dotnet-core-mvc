//$('form').on('submit', function (event) {
//    event.preventDefault();

//    $.ajax({
//        url: '/User/CreateUser',
//        method: 'POST',
//        data: $(this).serialize(),
//        success: function () {
//            // User created successfully
//            alert('User created!');
//        },
//        error: function (xhr) {
//            // Display the error message to the user
//            var errorMessage = xhr.responseText;
//            alert('Error creating user: ' + errorMessage);
//        }
//    });
//});