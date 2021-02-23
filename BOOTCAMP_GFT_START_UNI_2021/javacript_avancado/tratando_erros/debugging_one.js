let counter = 0;
let buttonAdd = document.querySelector('.add');
let buttonRemove = document.querySelector('.remove');
let counterText = document.querySelector('span');

function handleClick(btn, num){
  btn.addEventListener('click', () => counterText.innerHTML = counter += num);
}
handleClick(buttonAdd, 1)
handleClick(buttonRemove, -1)

console.log('Log')
console.warn('Log warning')
console.error('Log error')
console.trace('Log')
console.group('My log group')
console.log('First Log')
console.log('Second Log')
console.groupEnd('My log group')
console.time('My log time')
setTimeout(() => {
  console.timeEnd('My log time')
}, 1000)
console.table(['My log table', 'My log table'])
console.assert(1 === 1, 'Acertou')
console.assert(2 === 1, 'Ops')
console.log('%c styled log', 'color: green')