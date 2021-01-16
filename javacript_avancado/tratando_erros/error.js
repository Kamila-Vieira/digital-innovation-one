class CustomError extends Error{
  constructor({ message, data }){
    super(message);
    this.data = data;
  }
}

try {
  const name = 'Kamila';
  const myError = new CustomError({
    message: 'Custom message on custom error', 
    data: {
      type: 'Server error'
    }
  });
  throw myError;
}catch(err) {
  //console.log('All Error: ', err);
  console.log('Error message:', err.message)
  console.log('Error type:', err.data.type)
  if(err.data.type === 'Server error'){
    console.log('Erro no servidor!')
  } 
} finally {
  console.log('After Error...')
}