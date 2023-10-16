const element = document.querySelector('.zoom');

element.addEventListener('mouseenter', () => {
    element.classList.add('zoom-transitioning');
});

element.addEventListener('mouseleave', () => {
    element.addEventListener('transitionend', () => {
        element.classList.remove('zoom-transitioning');
    }, { once: true });
});