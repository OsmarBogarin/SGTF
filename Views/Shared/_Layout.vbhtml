<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title - SGTF</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- Tailwind CSS + Lucide -->
    <script src="https://cdn.tailwindcss.com"></script>
    <script src="https://unpkg.com/lucide@latest"></script>
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700&display=swap" rel="stylesheet">

    <style>
        body {
            font-family: 'Inter', sans-serif;
            background-color: #111827; /* bg-gray-900 */
        }

        .sidebar {
            background-color: #1f2937; /* bg-gray-800 */
        }

        .main-content {
            background-color: #111827; /* bg-gray-900 */
        }

        .card {
            background-color: #1f2937; /* bg-gray-800 */
        }

        .table-header {
            background-color: #374151; /* bg-gray-700 */
        }

        .table-row-even {
            background-color: #1f2937; /* bg-gray-800 */
        }

        .table-row-odd {
            background-color: #263142;
        }

        .modal-backdrop {
            background-color: rgba(0, 0, 0, 0.7);
        }

        .modal-content {
            background-color: #1f2937; /* bg-gray-800 */
        }

        ::-webkit-scrollbar {
            width: 8px;
        }

        ::-webkit-scrollbar-track {
            background: #1f2937;
        }

        ::-webkit-scrollbar-thumb {
            background: #4b5563;
            border-radius: 4px;
        }

            ::-webkit-scrollbar-thumb:hover {
                background: #6b7280;
            }
    </style>

    @RenderSection("Head", required:=False)
</head>
<body class="text-gray-200">
    <div class="flex h-screen">
        <!-- Sidebar -->
        <aside class="sidebar w-64 p-6 hidden lg:flex flex-col justify-between">
            <div>
                <div class="flex items-center gap-3 mb-10">
                    <div class="bg-green-500 p-2 rounded-lg">
                        <i data-lucide="shield-check" class="text-white"></i>
                    </div>
                    <h1 class="text-xl font-bold text-white">SGTF</h1>
                </div>
                <nav class="flex flex-col gap-2">
                    <a href="@Url.Action("Index", "Home")" class="flex items-center gap-3 px-4 py-2 rounded-lg hover:bg-gray-700">
                        <i data-lucide="layout-dashboard"></i><span>Dashboard</span>
                    </a>
                    <a href="@Url.Action("Index", "Torneo/Index")" class="flex items-center gap-3 px-4 py-2 rounded-lg bg-green-500/20 text-green-400 border-l-4 border-green-500">
                        <i data-lucide="trophy"></i><span>Torneos</span>
                    </a>
                    <a href="@Url.Action("Index", "Equipos")" class="flex items-center gap-3 px-4 py-2 rounded-lg hover:bg-gray-700">
                        <i data-lucide="users"></i><span>Equipos</span>
                    </a>
                    <a href="@Url.Action("Index", "Partidos")" class="flex items-center gap-3 px-4 py-2 rounded-lg hover:bg-gray-700">
                        <i data-lucide="calendar-days"></i><span>Partidos</span>
                    </a>
                    <a href="@Url.Action("Index", "Confederaciones")" class="flex items-center gap-3 px-4 py-2 rounded-lg hover:bg-gray-700">
                        <i data-lucide="globe-2"></i><span>Confederaciones</span>
                    </a>
                    <a href="@Url.Action("Index", "Palmares")" class="flex items-center gap-3 px-4 py-2 rounded-lg hover:bg-gray-700">
                        <i data-lucide="award"></i><span>Palmarés</span>
                    </a>
                    <a href="@Url.Action("Index", "Estadisticas")" class="flex items-center gap-3 px-4 py-2 rounded-lg hover:bg-gray-700">
                        <i data-lucide="bar-chart-3"></i><span>Estadísticas</span>
                    </a>
                    <div class="border-t border-gray-700 my-2"></div>
                    <a href="@Url.Action("Index", "Configuracion")" class="flex items-center gap-3 px-4 py-2 rounded-lg hover:bg-gray-700">
                        <i data-lucide="settings"></i><span>Configuración</span>
                    </a>
                </nav>
            </div>
            <div class="text-center text-gray-500 text-sm">
                <p>&copy; 2025 - SGTF</p>
            </div>
        </aside>

        <!-- Main Content -->
        <main class="flex-1 p-4 md:p-8 overflow-y-auto main-content">
            @RenderBody()
        </main>
    </div>

    <!-- Footer -->
    <footer class="text-center mt-10 text-sm text-gray-500 hidden lg:block">
        <p>&copy; 2025 SGTF</p>
    </footer>

    <!-- Lucide icons -->
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            lucide.createIcons();
        });
    </script>

    @RenderSection("Scripts", required:=False)
</body>
</html>
