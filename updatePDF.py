import os
import shutil
from subprocess import call
from os import path
from zipfile import *

every_file = os.listdir()

def is_selected(fn):
    suff = ['.doc', '.docx', '.ppt', '.pptx']
    _, ext = path.splitext(fn)
    return ext in suff

def new_filename(fn):
    base, _ = path.splitext(fn)
    return path.extsep.join((base, 'pdf'))

def convert(fn):
    new_fn = new_filename(fn)
    call(['cli2pdf', fn])
    # ask for rewrite
    os.system('copy /-y "%s" pdf' % new_fn)
    return new_fn

def is_outdated(fn):
    new_fn = path.join('pdf', new_filename(fn))
    return not path.exists(new_fn) or path.getmtime(fn) > path.getctime(new_fn)

lst = [i for i in every_file if is_selected(i) and is_outdated(i)]
if lst:
    zf = ZipFile('pdf\\newest.zip', 'w')
    for i in lst:
        new_fn = convert(i)
        zf.write(new_fn)
        os.remove(new_fn)
    zf.close()
else:
    print('Updated.')
