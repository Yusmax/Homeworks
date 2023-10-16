function toggleIcon() {
  const navbar = document.getElementById('navbar');
  const navBody = document.querySelector('.nav-body');

  navbar.classList.toggle('dark');
  navBody.classList.toggle('dark');
}
