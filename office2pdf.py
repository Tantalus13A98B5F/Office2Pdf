import win32com.client


msoTrue, msoFalse = -1, 0


def word2pdf(src, dst):
    wdExportFormatPDF = 17
    app = win32com.client.DispatchEx('Word.Application')
    doc = app.Documents.Open(src)
    doc.ExportAsFixedFormat(dst, wdExportFormatPDF)
    doc.Close()
    app.Quit()


def ppt2pdf(src, dst):
    ppSaveAsPDF = 32
    app = win32com.client.DispatchEx('PowerPoint.Application')
    ppt = app.Presentations.Open(src, msoTrue, msoFalse, msoFalse)
    ppt.SaveAs(dst, ppSaveAsPDF)
    ppt.Close()
    app.Quit()
