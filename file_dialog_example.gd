extends Control

@onready var file_dialog := $FileDialogExample as FileDialog

# Called when the node enters the scene tree for the first time.
func _ready():
	#get_window().content_scale_factor = 2.0
	file_dialog.visible = true;
	file_dialog.popup_centered()
